// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


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
    public string? descripción {get; set;} // información del rol, este atriburo se agrego para la entrega dos 
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
    public Boolean estado {get; set;} // si el libro se encuentra o no disponible 
    public DateTime año_publicacion {get; set;} // fecha en la que se publico el libro DUDA SI PONER DATETIME 
    public int id_editoriales {get; set;} // Relación real
    public Editoriales? _id_editoriales {get; set;}  // identificador de la editorial 
    public List<Libros_Generos>? Libros_Generos {get; set;}
    public List<Libros_Autores>? Libros_Autores {get; set;}
    public List<Prestamos_Libros>? Prestamos_Libros {get; set;}

}

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

///borrar mas tarde solo es un intento a ver que pasa 
public class Intento  // entidad que relaciona la entidad libros y la entidad autores
{

    public int id {get; set;} // identificador del autor del libro 
    public int id_libros {get; set;} // Relación real
    public int id_autores {get; set;} // Relación real
    public Libros? _id_libros {get; set;} // identificador del libro 
    public Autores? _id_autores {get; set;}  // identificador del prestamo 
    
}








