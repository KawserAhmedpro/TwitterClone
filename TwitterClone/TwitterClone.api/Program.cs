using TwitterClone.api.Data_storage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Swagger সার্ভিস রেজিস্টার করুন
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//repository registration
builder.Services.AddSingleton<UserRepository>();

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