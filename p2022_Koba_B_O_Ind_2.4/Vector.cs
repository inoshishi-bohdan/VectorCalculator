using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace p2022_Koba_B_O_Ind_2._4
{
    public class Vector
    {
		public Vector()
		{

		}

		public Vector(params double[] data)
		{
			vec_data = data;
		}

		private double [] vec_data;
		public double [] Data {get{ return vec_data; } set { vec_data = value; } }

        public override string ToString()
        {
			return String.Join(' ', vec_data);
        }
		public static Vector operator + (Vector v1, Vector v2)
		{
			if (v1.vec_data.Length == v2.vec_data.Length)
			{
				double[] data_new = new double[v1.vec_data.Length];
				for (int i = 0; i < data_new.Length; i++)
				{
					data_new[i] = v1.vec_data[i] + v2.vec_data[i];
				}
				return new Vector(data_new);
			}
			throw new Exception("Вектори не задовільняють умову : рівності вимірів векторів => v1.vec_data.Length==v2.vec_data.Length ");
		}
		public static Vector operator - (Vector v1, Vector v2)
		{
			if (v1.vec_data.Length == v2.vec_data.Length)
			{
				double[] data_new = new double[v1.vec_data.Length];
				for (int i = 0; i < data_new.Length; i++)
				{
					data_new[i] = v1.vec_data[i] - v2.vec_data[i];
				}
				return new Vector(data_new);
			}
			throw new Exception("Вектори не задовільняють умову : рівності вимірів векторів => v1.vec_data.Length==v2.vec_data.Length ");
		}
		public static double operator * (Vector v1, Vector v2)
		{
			if (v1.vec_data.Length == v2.vec_data.Length)
			{
				double scalar = 0;
				for (int i = 0; i < v1.vec_data.Length; i++)
				{
					scalar += v1.vec_data[i] * v2.vec_data[i];
				}
				return scalar;
			}
			throw new Exception("Вектори не задовільняють умову : рівності вимірів векторів => v1.vec_data.Length==v2.vec_data.Length ");
		}
		public static Vector operator * (Vector v1, double cons)
		{
			double[] data_new = new double[v1.vec_data.Length];
			for (int i = 0; i < data_new.Length; i++)
			{
				data_new[i] = v1.vec_data[i] * cons;
			}
			return new Vector(data_new);
		}
		public static Vector operator * (double cons, Vector v1)
		{
			double[] data_new = new double[v1.vec_data.Length];
			for (int i = 0; i < data_new.Length; i++)
			{
				data_new[i] = v1.vec_data[i] * cons;
			}
			return new Vector(data_new);
		}
	}
}
