﻿using Speckle.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Speckle.Objects.Primitive
{
  public class String : Base
  {
    public string value { get; set; }

    public String() { }

    public String(string value)
    {
      this.value = value;
    }

    public static implicit operator string(String s)
    {
      return s.value;
    }

    public static implicit operator String(string s)
    {
      return new String(s);
    }
  }
}
