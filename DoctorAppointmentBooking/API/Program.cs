using AppointmentBooking;

using AppointmentConfirmation;
using DoctorAppointmentManagement;
using DoctorAvailability;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDoctorAvailabilityModule();
builder.Services.AddAppointmentBookingModule();
builder.Services.AddAppointConfirmationModule();
builder.Services.AddDoctorAppointmentManagementModule();

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
