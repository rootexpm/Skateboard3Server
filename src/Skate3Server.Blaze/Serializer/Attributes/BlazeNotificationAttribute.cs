﻿using System;

namespace Skate3Server.Blaze.Serializer.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BlazeNotificationAttribute : BlazeResponseAttribute
    {
        public BlazeNotificationAttribute(BlazeComponent component, ushort command) : base(component, command)
        {
        }
    }
}