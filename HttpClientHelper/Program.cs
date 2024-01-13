using HttpClientHelper;
using HttpClientHelper.HttpClient.Abstract;
using HttpClientHelper.HttpClient.Concrate;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var _configuration = builder.Configuration;
var httpConfiguration = _configuration.GetSection("TestInternalServiceConfiguration");
builder.Services.Configure<TestInternalServiceConfiguration>(httpConfiguration);

builder.Services.AddHttpClient<IAknHttpClient<TestInternalServiceConfiguration>,AknHttpClient<TestInternalServiceConfiguration>>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
