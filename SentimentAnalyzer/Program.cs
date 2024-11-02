var builder = WebApplication.CreateBuilder(args);

var apiKey = builder.Configuration["GoogleCloud:ApiKey"];
builder.Services.AddSingleton(new SentimentAnalysisService(apiKey));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();


app.UseHttpsRedirection();

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
