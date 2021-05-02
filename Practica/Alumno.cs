using System;

namespace Practica
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno: Persona
	{
		private int legajo;
		private double promedio;
		
		public Alumno(){
		}
		
		public Alumno(int legajo)
		{
			this.legajo=legajo;
		}
		
		public Alumno(double promedio)
		{
			this.promedio=promedio;
		}
		
		public Alumno(string nombre, int dni, int legajo, double promedio)
		{
			this.legajo=legajo;
			this.promedio=promedio;
			this.nombre=nombre;
			this.dni=dni;	
		}
		
		public int getLegajo(){
			return legajo;
		}
		
		public double getPromedio(){
			return promedio;
		}
		
		public override bool sosIgual(Comparable obj){
			bool esIgual=false;
			if (legajo==((Alumno)obj).getLegajo()){
				esIgual=true;
		}
			return esIgual;
		}
		
		public override bool sosMenor(Comparable obj){
			bool esMenor=false;
			if (legajo<((Alumno)obj).getLegajo()){
				esMenor=true;
		}
			return esMenor;
		}
		
		public override bool sosMayor(Comparable obj){
			bool esMayor=false;
			if (legajo>((Alumno)obj).getLegajo()){
				esMayor=true;
		}
			return esMayor;
		}
		
		public new string informar(){
			return this.ToString();
		}
		
		public override string ToString()
		{
			return string.Format("{0}", legajo);
		}
 
	}
}
