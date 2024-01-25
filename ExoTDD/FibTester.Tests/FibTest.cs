
//- Lors du déclanchement de la fonction GetFibSeries() avec un Range de 6 
//  - Le résultat contient le chiffre 3 
//  - Le résultat contient 6 éléments 
//  - Le résultat n’a pas le chiffre 4 en son sein 
//  - Le résultat correspond à une liste qui contient {0, 1, 1, 2, 3, 5}
//  - Le résultat est trié de façon ascendance

using Exo.Bibliotheque;

namespace FibTester.Tests
{
    [TestClass]
    public class FibTest
    {
        // 1) Le résultat n’est pas vide
        [DataTestMethod]
        [DataRow(1)]
        public void GetFibSeries_Range_1_ShouldBe_NotNull(int r)
        {
            //Arrange
            Fib FibOne = new(r);

            // Act
            List<int> result = FibOne.GetFibSeries();

            //Assert
            Assert.IsNotNull(result);
        }

        // 2) Le résultat correspond à une liste qui contient {0}
        [DataTestMethod]
        [DataRow(1)]
        public void GetFibSeries_ShouldBe_Contains_0(int r)
        {
            //Arrange
            Fib FibOne = new(r);

            // Act
            List<int> result = FibOne.GetFibSeries();

            //Assert
            CollectionAssert.Contains(result, 0);
        }

        //- Lors du déclanchement de la fonction GetFibSeries() avec un Range de 6 

        // 3) Le résultat contient le chiffre 3 

        [DataTestMethod]
        [DataRow(6)]
        public void GetFibSeries_ShouldBe_Contains_3_6(int r)
        {
            //Arrange
            Fib FibOne = new(r);

            // Act
            List<int> result = FibOne.GetFibSeries();

            //Assert
            CollectionAssert.Contains(result, 3);
        }

        // 4) Le résultat contient 6 éléments 
        [DataTestMethod]
        [DataRow(6)]
        public void GetFibSeries_ShouldBe_Count_6(int r)
        {

            //Arrange
            Fib FibOne = new(r);

            // Act
            List<int> result = FibOne.GetFibSeries();

            //Assert
            Assert.AreEqual(6, result.Count());
            CollectionAssert.AreEqual(new List<int> { 0, 1, 1, 2, 3, 5 }, result);
        }

        // 5) Le résultat n’a pas le chiffre 4 en son sein 
        [DataTestMethod]
        [DataRow(6)]
        public void GetFibSeries_ShouldBe_DoesNotContain_4(int r)
        {
            //Arrange
            Fib FibOne = new(r);

            // Act
            List<int> result = FibOne.GetFibSeries();

            //Assert
            CollectionAssert.DoesNotContain(result, 4);
        }

        // 6) Le résultat correspond à une liste qui contient {0, 1, 1, 2, 3, 5}
        [DataTestMethod]
        [DataRow(6)]
        public void GetFibSeries_ShouldBe_EqualAt_ListOf_6(int r)
        {
            //Arrange
            Fib FibOne = new(r);

            // Act
            List<int> result = FibOne.GetFibSeries();
            //Assert
            CollectionAssert.AreEqual(new List<int> { 0, 1, 1, 2, 3, 5 }, result);
        }

        // 7) Le résultat est trié de façon ascendente
        public void GetFibSeries_ShouldBe_OrderedByAsc(int r)
        {
            //Arrange
            Fib FibOne = new(r);

            // Act
            List<int> result = FibOne.GetFibSeries();
            var sortedResult = result;
            sortedResult.Sort();
            //Assert
            CollectionAssert.AreEqual(sortedResult, result);
        }
    }
}
