using Programacion_III;
using System.Linq;

namespace CollectionsTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(100000)]
        public void LegajoQueTerminaEn11(int cantidad)
        {
            AlumnosCollection alumnos = new AlumnosCollection();
            for (int i = 0; i < cantidad; i++) {
                alumnos.Add(new Alumnos(i, "Alumno", "Alumno"));
            }
            //
            int cant = (from Alumnos in alumnos
                        where (Alumnos.legajo % 100) == 11 
                        select Alumnos).Count();                        
            //            
            Assert.Equal(1000, cant);
            //
        }
    }
}