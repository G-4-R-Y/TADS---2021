using PetCare.Domain.Models;
using PetCare.Domain.Repositories;
using PetCare.Persistence.Data;
using System;

namespace PetCare.Persistence.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private PetCareDataContext _context = new PetCareDataContext();
        public OwnerModel GetByID(Guid ownerID)
        {
            throw new NotImplementedException();
        }
        public OwnerModel GetByEMail(string email)
        {
            throw new NotImplementedException();
        }

        public void Create(OwnerModel ownerModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(OwnerModel ownerModel)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Update(OwnerModel ownerModel)
        {
            throw new NotImplementedException();
        }
    }
}
