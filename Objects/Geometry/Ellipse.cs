﻿using Speckle.Objects.Primitive;
using Speckle.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Speckle.Objects.Geometry
{
  public class Ellipse : Base, ICurve
  {
    public double? firstRadius { get; set; }
    public double? secondRadius { get; set; }
    public Plane plane { get; set; }
    public Interval domain { get; set; }

    public Ellipse()
    {

    }

    public Ellipse(Plane plane, double radius1, double radius2, string applicationId = null)
    {
      this.plane = plane;
      this.firstRadius = radius1;
      this.secondRadius = radius2;
      this.applicationId = applicationId;
    }
  }
}
