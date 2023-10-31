using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhanSo.Tests
{
    public class PhanSoTests
    {
        [Fact]
        public void TestCong()
        {
            // Arrange
            PhanSo p1 = new PhanSo(1, 2);
            PhanSo p2 = new PhanSo(1, 3);

            // Act
            PhanSo sum = p1.Cong(p2);

            // Assert
            Assert.Equal(5, sum.Tu);
            Assert.Equal(6, sum.Mau);
        }
        [Fact]
        public void TestHamDungMacDinh()
        {
            PhanSo p = new PhanSo();

            Assert.Equal(0, p.Tu);
            Assert.Equal(0, p.Mau);
        }

        [Fact]
        public void TestHamDung2ThamSo()
        {
            PhanSo p = new PhanSo(2, 3);

            Assert.Equal(2, p.Tu);
            Assert.Equal(3, p.Mau);
        }

        [Fact]
        public void TestCong_PhanSoDuong()
        {
            PhanSo p1 = new PhanSo(1, 2);
            PhanSo p2 = new PhanSo(3, 4);
            PhanSo p3 = p1.Cong(p2);

            Assert.Equal(10, p3.Tu);
            Assert.Equal(8, p3.Mau);
        }

        [Fact]
        public void TestCong_PhanSoDuongv2()
        {
            PhanSo p1 = new PhanSo(15, 7);
            PhanSo p2 = new PhanSo(10, 9);
            PhanSo p3 = p1.Cong(p2);

            Assert.Equal(205, p3.Tu);
            Assert.Equal(63, p3.Mau);
        }

        [Fact]
        public void TestCong_PhanSoAm()
        {
            PhanSo p1 = new PhanSo(-1, 5);
            PhanSo p2 = new PhanSo(-12, 29);
            PhanSo p3 = p1.Cong(p2);

            Assert.Equal(-89, p3.Tu);
            Assert.Equal(145, p3.Mau);
        }

        [Fact]
        public void TestCong_PhanSoAmv2()
        {
            PhanSo p1 = new PhanSo(-529, 45);
            PhanSo p2 = new PhanSo(11, 5);
            PhanSo p3 = p1.Cong(p2);

            Assert.Equal(-86, p3.Tu);
            Assert.Equal(9, p3.Mau);
        }

        [Fact]
        public void TestTruDuong()
        {
            PhanSo p1 = new PhanSo(80, 13);
            PhanSo p2 = new PhanSo(56, 5);
            PhanSo p3 = p1.Tru(p2);

            Assert.Equal(-328, p3.Tu);
            Assert.Equal(65, p3.Mau);
        }

        [Fact]
        public void TestTruDuongv2()
        {
            PhanSo p1 = new PhanSo(100, 27);
            PhanSo p2 = new PhanSo(65, 10);
            PhanSo p3 = p1.Tru(p2);

            Assert.Equal(65, p3.Tu);
            Assert.Equal(54, p3.Mau);
        }

        [Fact]
        public void TestTruAm()
        {
            PhanSo p1 = new PhanSo(-15, 8);
            PhanSo p2 = new PhanSo(25, 7);
            PhanSo p3 = p1.Tru(p2);

            Assert.Equal(-305, p3.Tu);
            Assert.Equal(56, p3.Mau);
        }

        [Fact]
        public void TestTruAmv2()
        {
            PhanSo p1 = new PhanSo(-9, 506);
            PhanSo p2 = new PhanSo(156, 51);
            PhanSo p3 = p1.Tru(p2);

            Assert.Equal(-26465, p3.Tu);
            Assert.Equal(8602, p3.Mau);
        }

        [Fact]
        public void TestChiaDuong()
        {
            PhanSo p1 = new PhanSo(8, 15);
            PhanSo p2 = new PhanSo(12, 5);
            PhanSo p3 = p1.Chia(p2);

            Assert.Equal(2, p3.Tu);
            Assert.Equal(9, p3.Mau);
        }

        [Fact]
        public void TestChiaDuongv2()
        {
            PhanSo p1 = new PhanSo(75, 3);
            PhanSo p2 = new PhanSo(4, 15);
            PhanSo p3 = p1.Chia(p2);

            Assert.Equal(375, p3.Tu);
            Assert.Equal(4, p3.Mau);
        }

        [Fact]
        public void TestChiaAm()
        {
            PhanSo p1 = new PhanSo(-6, 7);
            PhanSo p2 = new PhanSo(9, 5);
            PhanSo p3 = p1.Chia(p2);

            Assert.Equal(-10, p3.Tu);
            Assert.Equal(21, p3.Mau);
        }

        [Fact]
        public void TestChiaAmv2()
        {
            PhanSo p1 = new PhanSo(-13, 45);
            PhanSo p2 = new PhanSo(-3, 8);
            PhanSo p3 = p1.Chia(p2);

            Assert.Equal(104, p3.Tu);
            Assert.Equal(135, p3.Mau);
        }
    }
}
