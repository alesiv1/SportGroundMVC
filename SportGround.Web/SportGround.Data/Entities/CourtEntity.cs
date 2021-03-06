﻿using System;
using System.Collections.Generic;

namespace SportGround.Data.Entities
{
	public class CourtEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual List<CourtWorkingDaysEntity> WorkingDays { get; set; }
		public virtual List<CourtBookingEntity> Bookings { get; set; }
	}
}
