using UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using UdemyCarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using UdemyCarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers;
using UdemyCarBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using UdemyCarBook.Application.Features.CQRS.Handlers.ContactHandlers;
using UdemyCarBook.Application.Features.RepositoryPattern;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.BlogInterfaces;
using UdemyCarBook.Application.Interfaces.CarPricingInterfaces;
using UdemyCarBook.Application.Interfaces.CarRepositories;
using UdemyCarBook.Application.Interfaces.ITagCloudInterfaces;
using UdemyCarBook.Application.Services;
using UdemyCarBook.Persistence.Context;
using UdemyCarBook.Persistence.Respositories;
using UdemyCarBook.Persistence.Respositories.BlogRepositories;
using UdemyCarBook.Persistence.Respositories.CarPricingRepositories;
using UdemyCarBook.Persistence.Respositories.CarRepositories;
using UdemyCarBook.Persistence.Respositories.CommentRepositories;
using UdemyCarBook.Persistence.Respositories.TagCloudRepositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));

builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIdQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();

builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIdQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIdQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarsWithBrandQueryHandler>();

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIdQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandHandler>();
builder.Services.AddScoped<UpdateCategoryCommandHandler>();
builder.Services.AddScoped<RemoveCategoryCommandHandler>();

builder.Services.AddScoped<GetContactQueryHandler>();
builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();

builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
