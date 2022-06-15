using StaffManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffManagement.DataAccess.Models
{
    public class SqlserverStaffRepository : IStaffRepository
    {
        private readonly AppDbContext dbcontext;

        public SqlserverStaffRepository(AppDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }
        public Staff Create(Staff staff)
        {
            dbcontext.Staffs.Add(staff);
            dbcontext.SaveChanges();
            return staff;
        }

        public Staff Delete(int id)
        {
            var staff = dbcontext.Staffs.Find(id);
            if (staff != null)
            {
                dbcontext.Staffs.Remove(staff);
                dbcontext.SaveChanges();
            }
            return staff;
        }

        public Staff Get(int id)
        {
            return dbcontext.Staffs.Find(id);
        }

        public IEnumerable<Staff> GetAll()
        {
            return dbcontext.Staffs;
        }

        public Staff Update(Staff updatedStaff)
        {
            var staff = dbcontext.Staffs.Attach(updatedStaff);
            staff.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbcontext.SaveChanges();
            return updatedStaff;
        }
    }
}
