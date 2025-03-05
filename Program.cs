// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var lista_editoriales = new List<Editoriales>();
lista_editoriales.Add(new Editoriales(){id=1, nombre="Bloomsbury", correo = "bloomsbury@gmail.com" });
lista_editoriales.Add(new Editoriales(){id=2, nombre="Minotauro", correo = "minotauro@gmail.com" });
lista_editoriales.Add(new Editoriales(){id=3, nombre="Ediciones de la U", correo = "edicionesdelau@gmail.com" });
lista_editoriales.Add(new Editoriales(){id=4, nombre="Fondo Editorial EIA", correo = "fondoedeia@gmail.com" });

var lista_generos = new List<Generos>();
lista_generos.Add(new Generos(){id=1, nombre="Acción", descripción="Género lleno de emociones, enfrentamientos y desafíos intensos"});
lista_generos.Add(new Generos(){id=2, nombre="Fantasía", descripción="Mundo imaginario con magia, criaturas y aventuras sobrenaturales"});
lista_generos.Add(new Generos(){id=3, nombre="Misterio", descripción="Historia centrada en resolver enigmas o crímenes"});
lista_generos.Add(new Generos(){id=4, nombre="Aventura", descripción="Viajes y exploraciones con riesgos y descubrimientos"});
lista_generos.Add(new Generos(){id=5, nombre="Mitología", descripción="Relatos sobre dioses, héroes y criaturas míticas"});
lista_generos.Add(new Generos(){id=6, nombre="Epica", descripción="Grandes batallas y héroes luchando por causas nobles"});
lista_generos.Add(new Generos(){id=7, nombre="Académico", descripción="Estudio y análisis detallado de temas específicos"});

var lista_libros = new List<Libros>();
lista_libros.Add(new Libros(){id=1, titulo="Harry Potter y el prisionero de Azkaban", cantidad=8, estado= "Disponible", año_publicacion= "1999", id_editoriales=1, _id_editoriales=lista_editoriales.FirstOrDefault(x=>x.id==1)});
lista_libros.Add(new Libros(){id=2, titulo="El señor de los anillos ", cantidad=4, estado="Disponible", año_publicacion="1054",id_editoriales=2, _id_editoriales=lista_editoriales.FirstOrDefault(x=>x.id==2)});
lista_libros.Add(new Libros(){id=3, titulo="Calculo integral", cantidad=5, estado="No disponible", año_publicacion="2016",id_editoriales=3, _id_editoriales=lista_editoriales.FirstOrDefault(x=>x.id==3)});
lista_libros.Add(new Libros(){id=4, titulo="Física de campos ", cantidad=7, estado="Disponible", año_publicacion="2021",id_editoriales=4, _id_editoriales=lista_editoriales.FirstOrDefault(x=>x.id==4)});

var lista_autores = new List<Autores>();
lista_autores.Add(new Autores(){id=1, nombre="Joanne", apellido ="Rowling" });
lista_autores.Add(new Autores(){id=2, nombre="John Ronald", apellido ="Tolkien" });
lista_autores.Add(new Autores(){id=3, nombre="Juan Pablo", apellido ="Cardona" });
lista_autores.Add(new Autores(){id=4, nombre="Juan Camilo", apellido ="Vasquez" });
lista_autores.Add(new Autores(){id=5, nombre="Eugenio", apellido ="Giraldo" });

var lista_roles = new List<Roles>();
lista_roles.Add(new Roles(){id=1, nombre="Estudiante", descripcion ="Estudiante de la organición" });
lista_roles.Add(new Roles(){id=2, nombre="Personal Administrativo", descripcion ="Personal administrativo que trabaja en la organización" });
lista_roles.Add(new Roles(){id=3, nombre="Docente", descripcion ="Docente que trabaja en la organización" });

var lista_usuarios = new List<Usuarios>();
lista_usuarios.Add(new Usuarios(){id = 1, nombre = "Ramiro", apellido = "Sanchez", correo = "ramiro123@gmail.com", telefono = "12345", id_roles = 1, _id_roles = lista_roles.FirstOrDefault(x => x.id == 1)});
lista_usuarios.Add(new Usuarios(){id = 2, nombre = "Isabela", apellido = "Perez", correo = "Isabelita@gmail.com", telefono = "67890", id_roles = 2, _id_roles = lista_roles.FirstOrDefault(x => x.id == 2)});
lista_usuarios.Add(new Usuarios(){id = 3, nombre = "Camilo", apellido = "Diaz", correo = "Cam89u76@hotmail.com", telefono = "13579", id_roles = 3, _id_roles = lista_roles.FirstOrDefault(x => x.id == 3)});



Console.WriteLine(lista_editoriales.Count);
Console.WriteLine(lista_generos.Count);
Console.WriteLine(lista_libros.Count);
Console.WriteLine(lista_autores.Count);
Console.WriteLine(lista_roles.Count);
Console.WriteLine(lista_usuarios.Count);




public class Editoriales // Hace parte de la información del libro y el admi ingresa los datos de la editorial 
{

    public int id {get; set;} // identificador de la editorial 
    public string? nombre {get; set;} // información de la editorial 
    public string? correo {get; set;} // información de la editorial, este atriburo se agrego para la entrega dos 
    public List<Libros>? Libros {get; set;}
}

public class Generos  // Hace parte de la información del libro y el admi ingresa los datos del genero del libro  
{

    public int id {get; set;}// identificador del genero
    public string? nombre {get; set;} // información del genero
    public string? descripción {get; set;} // información del genero, este atriburo se agrego para la entrega dos 
    public List<Libros_Generos>? Libros_Generos {get; set;}
}

public class Autores  // Hace parte de la información del libro y el admi ingresa los datos del Autor del libro 
{

    public int id {get; set;}// identificador del autor 
    public string? nombre {get; set;} // información del autor    
    public string? apellido {get; set;} // información del autor
    public List<Libros_Autores>? Libros_Autores {get; set;}
    
}

public class Roles  // Hace parte de la información del Usuario y el admi asigna el rol 
{

    public int id {get; set;} // identificador del rol del usuario 
    public string? nombre {get; set;} // información del rol
    public string? descripcion {get; set;} // información del rol, este atriburo se agrego para la entrega dos 
    public List<Usuarios>? Usuarios {get; set;}
}

public class Prestamos  // contiene la información del prestamo y el admi ingresa los datos 
{

    public int id {get; set;} // identificador del prestamo 
    public string? codigo {get; set;} // identificador del DUDDDDDDAAAA
    public DateTime fecha_prestamo {get; set;} // fecha en la que se realizo el prestamo 
    public DateTime fecha_devolucion {get; set;} // fecha en la que se debe entregar el libro 
    public int id_usuarios {get; set;} // Relación real
    public Usuarios? _id_usuarios {get; set;} // identificador de usuarios 
    public List<Usuarios>? Usuarios {get; set;}
    public List<Prestamos_Libros>? Prestamos_Libros {get; set;}

}

public class Libros  // contiene la información del libro y el admi ingresa los datos 

{

    public int id {get; set;} // identificador del libro 
    public string? titulo {get; set;} // Nombre del libro 
    public int cantidad {get; set;} // cantidad de libros que hay disponibles
    public string? estado {get; set;} // si el libro se encuentra o no disponible 
    public string? año_publicacion {get; set;} // Año en la que se publico el libro DUDA SI PONER DATETIME 
    public int id_editoriales {get; set;} // Relación real
    public Editoriales? _id_editoriales {get; set;}  // identificador de la editorial 
    public List<Libros_Generos>? Libros_Generos {get; set;}
    public List<Libros_Autores>? Libros_Autores {get; set;}
    public List<Prestamos_Libros>? Prestamos_Libros {get; set;}

}

public class Prestamos_Libros  // entidad que relaciona la entidad prestamos y la entidad libros, además tiene la fecha en la que se entrega el libro 
{

    public int id {get; set;} // identificador del prestamo del libro  
    public DateTime fecha_devolucion {get; set;} // fecha de entrega del libro 
    public int id_libros {get; set;} // Relación real
    public int id_prestamos {get; set;} // Relación real
    public Libros? _id_libros {get; set;} // identificador del libro 
    public Prestamos? _id_prestamos {get; set;}  // identificador del prestamo 
    
}

public class Libros_Autores  // entidad que relaciona la entidad libros y la entidad autores
{

    public int id {get; set;} // identificador del autor del libro 
    public int id_libros {get; set;} // Relación real
    public int id_autores {get; set;} // Relación real
    public Libros? _id_libros {get; set;} // identificador del libro 
    public Autores? _id_autores {get; set;}  // identificador del prestamo 
    
}

public class Libros_Generos  // entidad que relaciona la entidad libros y la entidad generos
{

    public int id {get; set;} // identificador del genero del libro 
    public int id_libros {get; set;}
    public int id_generos {get; set;}
    public Libros? _id_libros {get; set;} // identificador del libro 
    public Generos? _id_generos {get; set;}  // identificador del genero 
    
}

public class Usuarios   // contiene la información del usuario y el admi ingresa los datos 

{

    public int id {get; set;} // identificador del usuario 
    public string? nombre {get; set;} // información del usuario 
    public string? apellido {get; set;} // información del usuario 
    public string? correo {get; set;} // información de contacto del usuario 
    public string? telefono {get; set;} // información de contacto del usuario 
    public int id_roles {get; set;} // Relación real
    public Roles? _id_roles {get; set;} // identificar del rol 
    
}























