﻿using System;
using VacationRental.Domain.Common;
using VacationRental.Domain.Values;

namespace VacationRental.Domain.Entities
{
    public class Booking : Entity<BookingId>
    {
        public Booking(BookingId id, RentalId rentalId, BookingPeriod period)
        {
            Id = id;
            RentalId = rentalId;
            Period = period;
        }

        public BookingId Id { get; }
        public RentalId RentalId { get;}
        public BookingPeriod Period { get; }

        public bool IsOverlapped(BookingPeriod periodToCompare) => Period.IsOverlapped(periodToCompare);
        public bool Within(DateTime date) => Period.Within(date);
    }
}
