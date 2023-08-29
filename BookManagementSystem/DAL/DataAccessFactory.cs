using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Booklist, int, Booklist> BooklistDataAccess()
        {
            return new BooklistRepo();
        }
        public static IRepo<SellerRegistration, int, SellerRegistration> SellerRegistrationDataAccess()
        {
            return new SellerRegistrationRepo();
        }
        public static IAdminRepo<AdminReg, int, bool> AdminDataAcccess()
        {
            return new AdminRepo();
        }

        public static IRepo<Author, int, Author> AuthorDataAccess()
        {
            return new AuthorRepo();
        }

        public static IRepo<Genre, int, Genre> GenreDataAccess()
        {
            return new GenreRepo();
        }
    }
}
