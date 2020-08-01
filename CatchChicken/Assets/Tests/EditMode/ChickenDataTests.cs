using System;
using System.Collections;
using System.Collections.Generic;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public partial class ChickenDataTests
    {
        public partial class ChickenProperty
        {
            ChickenData chickenData;

            [SetUp]
            public void InitClass()
            {
                chickenData = Substitute.For<ChickenData>();
            }
            // A Test behaves as an ordinary method
            [Test]
            public void Should_ReturnObject_When_InitialClass()
            {
                Assert.IsNotNull(chickenData);
            }

            [Test]
            public void Should_ReturnSpeedValue_When_SpeedValueIsSet()
            {
                chickenData.Speed = 1f;
                Assert.AreEqual(1f, chickenData.Speed);
            }

            [Test]
            public void Should_ReturnZero_When_SpeedValueIsSetNegative()
            {
                chickenData.Speed = -1f;
                Assert.AreEqual(0f, chickenData.Speed);
            }

            [Test]
            public void Should_ReturnStunTime_When_StunTimeIsSet()
            {
                chickenData.StunTime = 1f;
                Assert.AreEqual(1f, chickenData.StunTime);
            }

            [Test]
            public void Should_ReturnZero_When_StunTimeIsSetNegative()
            {
                chickenData.StunTime = -1f;
                Assert.AreEqual(0f, chickenData.StunTime);
            }

            [Test]
            public void Should_ReturnMaxValue_When_StunTimeIsSetOverMaxStunTime()
            {
                chickenData.StunTime = 3f;
                Assert.AreEqual(ChickenData.MaxStunTime, chickenData.StunTime);
            }

            [Test]
            public void Should_ReturnCatchable_When_CatchableIsSet()
            {
                chickenData.Catchable = .5f;
                Assert.AreEqual(.5f, chickenData.Catchable);
            }

            [Test]
            public void Should_ReturnZero_When_CatchableIsSetNegative()
            {
                chickenData.Catchable = -1f;
                Assert.AreEqual(0f, chickenData.Catchable);
            }

            [Test]
            public void Should_ReturnOne_When_CatchableIsSetOverOne()
            {
                chickenData.Catchable = 1.5f;
                Assert.AreEqual(1f, chickenData.Catchable);
            }

            [Test]
            public void Should_NotNull_When_ChickenImageSet()
            { 
                var sprite = Sprite.Create(
                    Texture2D.normalTexture,
                    Rect.zero,
                    Vector2.zero);

                chickenData.ChickenSprite = sprite;

                Assert.IsNotNull(chickenData.ChickenSprite);
            }
        }
    }
}
