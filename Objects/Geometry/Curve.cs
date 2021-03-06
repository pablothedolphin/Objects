﻿using Speckle.Objects.Primitive;
using Speckle.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Speckle.Objects.Geometry
{
  public class Curve : Base, ICurve
  {
    public int degree { get; set; }
    public bool periodic { get; set; }
    public bool rational { get; set; }
    public List<double> points { get; set; }
    public List<double> weights { get; set; }
    public List<double> knots { get; set; }
    public Interval domain { get; set; }
    public Polyline displayValue { get; set; }
    public bool closed { get; set; }
    public Curve()
    {
    }
    public Curve(Polyline poly, string applicationId = null)
    {
      this.displayValue = poly;
      this.applicationId = applicationId;
    }
  }
}
