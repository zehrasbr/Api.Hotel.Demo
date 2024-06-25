using HotelProject.DataAccessLayer.Abstarct;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        public EfBookingDal(Context context) : base(context) { }

        public void BookingStatusChangeApproved(Booking booking)
        {
            var context = new Context();
            var values = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
            values.Status = "Onaylandı";
            context.SaveChanges();
        }

        public void BookingStatusChangeApproved2(int id)
        {
            throw new NotImplementedException();
        }

        public void BookingStatusChangeApproved3(int id)
        {
            throw new NotImplementedException();
        }

        public void BookingStatusChangeCancel(int id)
        {
            throw new NotImplementedException();
        }

        public void BookingStatusChangeWait(int id)
        {
            throw new NotImplementedException();
        }

        public int GetBookingCount()
        {
            throw new NotImplementedException();
        }

        public List<Booking> Last6Bookings()
        {
            throw new NotImplementedException();
        }
    }
}
