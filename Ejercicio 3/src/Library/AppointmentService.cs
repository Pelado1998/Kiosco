﻿using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        // La clase AppointmentService no cumple con Expert ya que no es el experto 
        // de los datos para crear el appointment. Vienen de afuera.
        // La clase AppointmentService cumple cumple con SRP ya que
        // crear el appointment si se puede.
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}