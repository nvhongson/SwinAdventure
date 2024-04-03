﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
 
namespace SwinAdventure
{
    public class TestItem
    {
        // Item Clarification
        Item shovel = new Item(new string[] {"shovel"},"a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");


        [SetUp]
        // Setup
        public void Setup()
        {

        }

        [Test]
        // Item Identifier
        public void TestItemIdentifiable()
        {
            var result = shovel.AreYou("sword");
            Assert.IsFalse(result); //Item cannot be defined

            var result2 = shovel.AreYou("shovel");
            Assert.IsTrue(result2);

        }

        [Test]
        // Item Description Short
        public void TestShortDescription()
        {
            Assert.AreEqual(shovel.ShortDescription, "a shovel (shovel)"); //Description Correct!
            Assert.AreNotEqual(shovel.ShortDescription, "This is a shovel"); //Testing short with long Description showing they are not Correct!
        }

        [Test]
        // Item Description Full
        public void TestFullDescription()
        {
            Assert.AreEqual(shovel.FullDesciption, "This is a shovel"); //Full Description is Correct!
            Assert.AreNotEqual(shovel.FullDesciption, "a shovel (shovel)"); //Full Description is not Correct!

        }
    }
}
