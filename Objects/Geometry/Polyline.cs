﻿using Newtonsoft.Json;
using Speckle.Objects.Primitive;
using Speckle.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Speckle.Objects.Geometry
{
  public class Polyline : Base, ICurve
  {
    public List<double> value { get; set; } = new List<double>();
    public bool closed { get; set; }
    public Interval domain { get; set; }
    public Polyline()
    {

    }
    public Polyline(IEnumerable<double> coordinatesArray, string applicationId = null)
    {
      this.value = coordinatesArray.ToList();
      this.applicationId = applicationId;
    }

    [JsonIgnore]
    public List<Point> points
    {
      get
      {
        List<Point> points = new List<Point>();
        for (int i = 0; i < value.Count; i += 3)
        {
          points.Add(new Point(value[i], value[i + 1], value[i + 2]));
        }
        return points;
      }
    }
  }
}
