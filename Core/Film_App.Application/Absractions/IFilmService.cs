using Film_App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_App.Application.Absractions
{
    public interface IFilmService
    {
        List<Film> GetFilms();
    }
}
