using AvaluoInmobiliario.Models;

namespace AvaluoInmobiliario.Data
{
    public class DataSeeder
    {
        private readonly ApplicationDbContext _context;

        public DataSeeder(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            if (!_context.AvaluoEstatus.Any())
            {
                var estatus1 = new AvaluoEstatus { Descripcion = "Nuevo" };
                var estatus2 = new AvaluoEstatus { Descripcion = "En Proceso" };
                var estatus3 = new AvaluoEstatus { Descripcion = "Cerrado" };

                _context.AvaluoEstatus.AddRange(estatus1, estatus2, estatus3);

                _context.SaveChanges();
            }
        }

    }
}
