using System;
namespace Eventify_Tutorial_Series_OnionArchitecture.Domain.Comman
{
	public class EntityBase
	{
		public Guid Id { get; set; }

		public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }
    }
}

