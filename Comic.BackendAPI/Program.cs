using Comic.Application.Categories;
using Comic.Application.ChapterComics;
using Comic.Application.ComicStrips;
using Comic.Application.DetailComics;
using Comic.Application.Genders;
using Comic.Application.HistoryReadComicOfUsers;
using Comic.Application.ListOfComicsUsersFollows;
using Comic.Application.Users;
using Comic.Data.EF;
using Comic.Data.Entities;
using Comic.ViewModels.Users.UserRequestValidator;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("ComicDB");
builder.Services.AddDbContext<ComicDbContext>(x => x.UseSqlServer(connectionString));

builder.Services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<ComicDbContext>()
                .AddDefaultTokenProviders();

builder.Services.AddTransient<IGenderService, GenderService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<IDetailComicService, DetailComicService>();
builder.Services.AddTransient<IComicStripService, ComicStripSerive>();
builder.Services.AddTransient<IListOfComicsUsersFollowService, ListOfComicsUsersFollowService>();
builder.Services.AddTransient<IHistoryReadComicOfUserService, HistoryReadComicOfUserService>();
builder.Services.AddTransient<IChapterComicService, ChapterComicService>();

builder.Services.AddTransient<UserManager<AppUser>, UserManager<AppUser>>();
builder.Services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
builder.Services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();

var ApiAllowSpecificOrigins = "_apiAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: ApiAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
                      });
});

//builder.Services.AddControllers();
builder.Services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<LoginRequestValidator>());


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        { new OpenApiSecurityScheme { Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer"},
                          Scheme = "oauth2", Name = "Bearer", In = ParameterLocation.Header, }, new List<string>()  }
    });
});

string issuer = builder.Configuration.GetSection("Tokens:Issuer").Value;
string signingKey = builder.Configuration.GetSection("Tokens:Key").Value;
byte[] signingKeyBytes = System.Text.Encoding.UTF8.GetBytes(signingKey);

builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidIssuer = issuer,
        ValidateAudience = true,
        ValidAudience = issuer,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = System.TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(signingKeyBytes)
    };
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseRouting();

app.UseCors(ApiAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();