using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Skills
{
    public class ResultUseSkill
    {
        public bool IsSuccess { get; private set; }
        public int Value { get; private set; }

        public string Desc { get; private set; }

        public Color Color { get; private set; }

        public ResultUseSkill(bool isSuccess, int value, string desc, Color color)
        {
            IsSuccess = isSuccess;
            Value = value;
            Desc = desc;
            Color = color;
        }
    }
}
