using TestePratico.Controllers;
using TestePratico.Models;

namespace DecomposicaoTeste
{
    public class UnitTest1
    {
        [Fact]
        public void TestFuncPrimoTrue()
        {
           //Arange
           Numero numero = new Numero();
           List<int> listNumTestTrue = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 229, 233, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997];

            //Act
            bool teste = listNumTestTrue.All(numero.Primo);

            //Assert
            Assert.True(teste);
        }

        [Fact]
        public void TestFuncPrimoFalse()
        {
            //Arange
            Numero numero = new Numero();
            List<int> listNumTestFalse = [0, 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 25, 26, 27, 28, 30, 32, 33, 34, 35, 36, 38, 39, 40, 42, 44, 45, 46, 48, 49, 50, 51, 52, 54, 55, 56, 57, 58, 60, 62, 63, 64, 65, 66, 68, 69, 70, 72, 74, 75, 76, 77, 78, 80, 81, 82, 84, 85, 86, 87, 88, 90, 91, 92, 93, 94, 95, 96, 98, 99, 100, 204, 205, 206, 207, 208, 209, 210, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 224, 225, 226, 228, 230, 231, 232, 234, 235, 236, 237, 238, 240, 242, 243, 244, 245, 246, 247, 248, 249, 250];

            //Act
            bool teste = listNumTestFalse.All(numero.Primo);

            //Assert
            Assert.False(teste);
        }
        [Fact]
        public void TestDecomposicao1()
        {
            //Arange
            Numero numero = new Numero();

            //Act
            var teste = numero.Decomposicao(40);

            //Assert
            Assert.NotNull(teste.Divisores);
            Assert.NotNull(teste.DivisoresPrimos);
            Assert.Equal(40, teste.Num);
            Assert.Equal("1, 2, 4, 5, 8, 10, 20, 40", teste.Divisores);
            Assert.Equal("2, 5", teste.DivisoresPrimos);
           
        }
        [Fact]
        public void TestDecomposicao2()
        {
            //Arange
            Numero numero = new Numero();

            //Act
            var teste = numero.Decomposicao(8884);

            //Assert
            Assert.NotNull(teste.Divisores);
            Assert.NotNull(teste.DivisoresPrimos);
            Assert.Equal(8884, teste.Num);
            Assert.Equal("1, 2, 4, 2221, 4442, 8884", teste.Divisores);
            Assert.Equal("2, 2221", teste.DivisoresPrimos);
           
        }
        [Fact]
        public void TestDecomposicao3()
        {
            //Arange
            Numero numero = new Numero();

            //Act
            var teste = numero.Decomposicao(2221);

            //Assert
            Assert.NotNull(teste.Divisores);
            Assert.NotNull(teste.DivisoresPrimos);
            Assert.Equal(2221, teste.Num);
            Assert.Equal("1, 2221", teste.Divisores);
            Assert.Equal("2221", teste.DivisoresPrimos);
            
        }
        [Fact]
        public void TestDecomposicao4()
        {
            //Arange
            Numero numero = new Numero();

            //Act
            var teste = numero.Decomposicao(4442);

            //Assert
            Assert.NotNull(teste.Divisores);
            Assert.NotNull(teste.DivisoresPrimos);
            Assert.Equal(4442, teste.Num);
            Assert.Equal("1, 2, 2221, 4442", teste.Divisores);
            Assert.Equal("2, 2221", teste.DivisoresPrimos);
            
        }
        [Fact]
        public void TestDecomposicao5()
        {
            //Arange
            Numero numero = new Numero();

            //Act
            var teste = numero.Decomposicao(1);

            //Assert
            Assert.NotNull(teste.Divisores);
            Assert.NotNull(teste.DivisoresPrimos);
            Assert.Equal(1, teste.Num);
            Assert.Equal("1", teste.Divisores);
            Assert.Equal("", teste.DivisoresPrimos);

        }
        [Fact]
        public void TestDecomposicaoZero()
        {
            //Arange
            Numero numero = new Numero();

            //Act
            var teste = numero.Decomposicao(0);

            //Assert
            Assert.NotNull(teste.Divisores);
            Assert.NotNull(teste.DivisoresPrimos);
            Assert.Equal(0, teste.Num);
            Assert.Equal("", teste.Divisores);
            Assert.Equal("", teste.DivisoresPrimos);
        }

    }
}