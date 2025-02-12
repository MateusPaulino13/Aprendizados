﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecoesPersonalizadas.Entites
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            // ve a diferença entra as datas em timespan
            TimeSpan duration = CheckOut.Subtract(CheckIn);

            // retorna a diferença em dias com double
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                return "Error in reservation: Reservation dates for update must be future dates";
            }

            if (checkOut <= checkIn)
            {
                return "Error in reservation: CheckOut date must be after chekIn date";
            }

            CheckIn = CheckIn;
            CheckOut = checkOut;

            return null;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }
    }
}