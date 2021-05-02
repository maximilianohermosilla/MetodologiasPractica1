using System;

namespace Practica
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Coleccionable cola = new Cola<Comparable>();
			Coleccionable pila = new Pila<Comparable>();
						
			llenar(cola);
			informar(cola);
			llenar(pila);
			informar(pila);
			
			ColeccionMultiple multiple = new ColeccionMultiple(((Pila<Comparable>)pila), ((Cola<Comparable>)cola));
			informar(multiple);
			
			Coleccionable colaPersonas = new Cola<Comparable>();
			llenarPersonas(colaPersonas);
			Coleccionable pilaPersonas = new Pila<Comparable>();
			llenarPersonas(pilaPersonas);
			
			ColeccionMultiple multiplePersonas = new ColeccionMultiple(((Pila<Comparable>)pilaPersonas), ((Cola<Comparable>)colaPersonas));
			informar(multiplePersonas);
			
			Coleccionable colaAlumnos = new Cola<Comparable>();
			llenarAlumnos(colaAlumnos);
			Coleccionable pilaAlumnos = new Pila<Comparable>();
			llenarAlumnos(pilaAlumnos);
			
			ColeccionMultiple multipleAlumnos = new ColeccionMultiple(((Pila<Comparable>)pilaAlumnos), ((Cola<Comparable>)colaAlumnos));
			informar(multipleAlumnos);			
			
			Console.ReadKey();
			
			
		}
		
		public static void llenar(Coleccionable lista){
			Random random = new Random();
			for (int x=1; x<=20 ; x++){
				Comparable numero = new Numero(random.Next(1,100));
				((Coleccionable)lista).agregar(numero);
			}
		}
		
		public static void informar(Coleccionable lista){
			try{
			//Comparable comparable;
			Console.Write("Cantidad de elementos: ");
			Console.WriteLine(lista.cuantos());
			Console.Write("Mínimo: ");
			Console.WriteLine(lista.menor().informar());
			Console.Write("Máximo: ");
			Console.WriteLine(lista.mayor().informar());
			Console.Write("Ingrese número: ");
			string num = Console.ReadLine();
			//comparable = new Numero(num);
			if (lista.contieneNumero(num)){
				Console.WriteLine("El elemento leído está en la colección");
			}
			else{
				Console.WriteLine("El elemento leído NO está en la colección");
			}
			}
			catch(FormatException){
				Console.WriteLine("* Numero invalido *");
				Console.ReadKey(true);
			}
		}
		/*
		public static void informar(Coleccionable lista){
			try{
			Comparable comparableNum;
			Console.Write("Cantidad de elementos: ");
			Console.WriteLine(lista.cuantos());
			if(lista.menor().GetType() == Type.GetType("Practica.Numero")){
				Console.Write("Mínimo: ");
				Console.WriteLine(((Numero)lista.menor()).getValor());
				Console.Write("Máximo: ");
				Console.WriteLine(((Numero)lista.mayor()).getValor());
				Console.Write("Ingrese número: ");
				string num = Console.ReadLine();
				comparableNum = new Numero(int.Parse(num));
				if (lista.contiene((Comparable)comparableNum)){
					Console.WriteLine("El elemento leído está en la colección");
				}
				else{
					Console.WriteLine("El elemento leído NO está en la colección");				
				}
			}
			
			else if (lista.menor().GetType() == Type.GetType("Practica.Persona")){
				Console.Write("DNI Mínimo: ");
				Console.WriteLine(((Persona)lista.menor()).getDni());
				Console.Write("DNI Máximo: ");
				Console.WriteLine(((Persona)lista.mayor()).getDni());
				Console.Write("Ingrese número de DNI: ");
				string num = Console.ReadLine();
				comparableNum = new Persona(int.Parse(num));
				if (lista.contiene((Comparable)comparableNum)){
					Console.WriteLine("El elemento leído está en la colección");
				}
				else{
					Console.WriteLine("El elemento leído NO está en la colección");				
				}
			}
			
			else if (lista.menor().GetType() == Type.GetType("Practica.Alumno")){
				Console.Write("Legajo Mínimo: ");
				Console.WriteLine(((Alumno)lista.menor()).getLegajo());
				Console.Write("Legajo Máximo: ");
				Console.WriteLine(((Alumno)lista.mayor()).getLegajo());
				Console.Write("Ingrese número de Legajo: ");
				string num = Console.ReadLine();
				Alumno comparable = new Alumno(int.Parse(num));
				if (lista.contiene((Comparable)comparable)){
					Console.WriteLine("El elemento leído está en la colección");
				}
				else{
					Console.WriteLine("El elemento leído NO está en la colección");				
				}
			}
			}
			catch(FormatException){
				Console.WriteLine("* Numero invalido *");
				Console.ReadKey(true);
			}
		}
		*/
		public static void llenarPersonas(Coleccionable lista){
			Random random = new Random();
			string nombre;
			int dni;
			string[] nombres=new string[]{"Maxi","Paula","Roberto","Nacho","Adrian","Diego","Lucia","Florencia","Cintia","Ana","Graciela","Yesica","Daiana","Carolina","Gaston","Luis","Jacinto","Ramona","Ignacia","Viviana"};
			for (int x=1; x<=20 ; x++){
				nombre=nombres[random.Next(0,19)];
				dni=random.Next(12000000,40000000);
				Comparable persona = new Persona(nombre,dni);
				((Coleccionable)lista).agregar(persona);
				//Console.Write(((Persona)persona).getNombre() + " " + ((Persona)persona).getDni().ToString() + "\n");
			}
		}
		
		public static void llenarAlumnos(Coleccionable lista){
			Random random = new Random();
			string nombre;
			int dni;
			int legajo;
			double promedio;
			string[] nombres=new string[]{"Maxi","Paula","Roberto","Nacho","Adrian","Diego","Lucia","Florencia","Cintia","Ana","Graciela","Yesica","Daiana","Carolina","Gaston","Luis","Jacinto","Ramona","Ignacia","Viviana"};
			for (int x=1; x<=20 ; x++){
				nombre=nombres[random.Next(0,19)];
				dni=random.Next(12000000,40000000);
				legajo=random.Next(1,2000);
				promedio=random.Next(0,10);
				Comparable alumno = new Alumno(nombre,dni,legajo,promedio);
				((Coleccionable)lista).agregar(alumno);
				//Console.Write(((Alumno)alumno).getNombre() + " " + ((Alumno)alumno).getDni().ToString() + " " + ((Alumno)alumno).getLegajo() + " " + ((Alumno)alumno).getPromedio().ToString() + "\n");
			}
		}
	}
}