﻿// Copyright (c) Christof Senn. All rights reserved. See license.txt in the project root for license information.

namespace Aqua.Tests.Dynamic.DynamicObject
{
    using Aqua.Dynamic;
    using System;
    using Xunit;
    using Xunit.Should;

    public class When_converting_to_serializable_object_with_private_property_setters
    {
        [Serializable]
        class SerializableType
        {
            public int Int32Value { get; set; }
            public double DoubleValue { get; private set; }
            public string StringValue { get; private set; }
        }

        const int Int32Value = 11;
        const double DoubleValue = 12.3456789;
        const string StringValue = "eleven";

        SerializableType obj;

        public When_converting_to_serializable_object_with_private_property_setters()
        {
            var dynamicObject = new DynamicObject
            {
                { "Int32Value", Int32Value },
                { "DoubleValue", DoubleValue },
                { "StringValue", StringValue },
            };

            obj = dynamicObject.CreateObject<SerializableType>();
        }

        [Fact]
        public void Should_create_an_instance()
        {
            obj.ShouldNotBeNull();
        }

        [Fact]
        public void Should_have_the_int_property_set()
        {
            obj.Int32Value.ShouldBe(Int32Value);
        }

        [Fact]
        public void Should_have_the_double_property_set()
        {
            obj.DoubleValue.ShouldBe(DoubleValue);
        }

        [Fact]
        public void Should_have_the_string_property_set()
        {
            obj.StringValue.ShouldBe(StringValue);
        }
    }
}