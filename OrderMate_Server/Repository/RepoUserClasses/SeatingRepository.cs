using Contacts.Interfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.RepoUserClasses
{
    public class SeatingRepository: RepositoryBase<Seating>, ISeatingRepository
    {
        public SeatingRepository(OrderMateDbDel08Context repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateSeating(Seating seating)
        {
            Create(seating);
        }

        public void DeleteSeating(Seating seating)
        {
            Delete(seating);
        }

        public IEnumerable<Seating> GetAllSeatings()
        {
            return FindAll()
                .OrderBy(x => x.SeatingTime)
                .ToList();
        }

        public Seating GetSeatingById(int seatingId)
        {
            return FindByCondition(x => x.SeatingId.Equals(seatingId))
                .FirstOrDefault();
        }

        public Seating GetSeatingWithDetails(int seatingId)
        {
            return FindByCondition(x => x.SeatingId.Equals(seatingId))
                .Include(x => x.QrCodeSeating)
                .Include(x => x.ReservationIdFkNavigation)
                .FirstOrDefault();
        }

        public void UpdateSeating(Seating seating)
        {
            Update(seating);
        }
    }
}
