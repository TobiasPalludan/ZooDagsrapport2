﻿using System;
using AalborgZooProjekt;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AalborgZooProjekt.Model;

namespace NUnit.Test
{
    [TestFixture]
    public class ProductVersionTester
    {
        [TestCase(true, "Frugt Karl")]
        [TestCase(false, "Frugt Karl")]
        public void TestActive(bool active, string supplier)
        {
            string today = DateTime.Today.ToString();
            ProductVersion product = new ProductVersion(active, supplier, today);

            MakeActive(product);
            Assert.IsTrue(product.IsActive);
        }

        private void MakeActive(ProductVersion product)
        {
            if (!product.IsActive)
            {
                product.IsActive = true;
            }
        }
    }
}