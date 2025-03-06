// See https://aka.ms/new-console-template for more information
using System.ComponentModel;


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


var lista_libros = new List<Libros>();
lista_libros.Add(new Libros(){id=1, titulo="Harry Potter y el prisionero de Azkaban", cantidad=8, estado= "Disponible", año_publicacion= "1999", id_editoriales=1, _id_editoriales=lista_editoriales.FirstOrDefault(x=>x.id==1)});
lista_libros.Add(new Libros(){id=2, titulo="El señor de los anillos ", cantidad=4, estado="Disponible", año_publicacion="1054",id_editoriales=2, _id_editoriales=lista_editoriales.FirstOrDefault(x=>x.id==2)});
lista_libros.Add(new Libros(){id=3, titulo="Calculo integral", cantidad=5, estado="No disponible", año_publicacion="2016",id_editoriales=3, _id_editoriales=lista_editoriales.FirstOrDefault(x=>x.id==3)});
lista_libros.Add(new Libros(){id=4, titulo="Física de campos ", cantidad=7, estado="Disponible", año_publicacion="2021",id_editoriales=4, _id_editoriales=lista_editoriales.FirstOrDefault(x=>x.id==4)});

var lista_usuarios = new List<Usuarios>();
lista_usuarios.Add(new Usuarios(){id = 1, nombre = "Ramiro", apellido = "Sanchez", correo = "ramiro123@gmail.com", telefono = "12345", id_roles = 1, _id_roles = lista_roles.FirstOrDefault(x => x.id == 1)});
lista_usuarios.Add(new Usuarios(){id = 2, nombre = "Isabela", apellido = "Perez", correo = "Isabelita@gmail.com", telefono = "67890", id_roles = 2, _id_roles = lista_roles.FirstOrDefault(x => x.id == 2)});
lista_usuarios.Add(new Usuarios(){id = 3, nombre = "Camilo", apellido = "Diaz", correo = "Cam89u76@hotmail.com", telefono = "13579", id_roles = 3, _id_roles = lista_roles.FirstOrDefault(x => x.id == 3)});

var lista_prestamos = new List<Prestamos>();
lista_prestamos.Add(new Prestamos(){id=1, codigo="Ax1", fecha_prestamo= new DateTime(2025,02,24), fecha_devolucion=new DateTime(2025,03,03), id_usuarios=1, _id_usuarios = lista_usuarios.FirstOrDefault(x => x.id == 1)});
lista_prestamos.Add(new Prestamos(){id=2, codigo="Ax1", fecha_prestamo= new DateTime(2025,02,24), fecha_devolucion=new DateTime(2025,03,05), id_usuarios=1, _id_usuarios = lista_usuarios.FirstOrDefault(x => x.id == 1)});
lista_prestamos.Add(new Prestamos(){id=3, codigo="Ax2", fecha_prestamo= new DateTime(2025,02,22), fecha_devolucion=new DateTime(2025,03,25), id_usuarios=2, _id_usuarios = lista_usuarios.FirstOrDefault(x => x.id == 2)});
lista_prestamos.Add(new Prestamos(){id=4, codigo="Ax3", fecha_prestamo= new DateTime(2025,03,03) , fecha_devolucion=new DateTime(2025,03,03), id_usuarios=3, _id_usuarios = lista_usuarios.FirstOrDefault(x => x.id == 3)});

var lista_prestamos_libros= new List<Prestamos_Libros>();
lista_prestamos_libros.Add(new Prestamos_Libros(){id=1, fecha_devolucion= new DateTime(2025,03,03), id_libros=1, id_prestamos=1, _id_libros=lista_libros.FirstOrDefault( x=> x.id == 1), _id_prestamos=lista_prestamos.FirstOrDefault( x=> x.id == 1)});
lista_prestamos_libros.Add(new Prestamos_Libros(){id=2, fecha_devolucion= new DateTime(2025,02,24), id_libros=2, id_prestamos=2, _id_libros=lista_libros.FirstOrDefault( x=> x.id == 2), _id_prestamos=lista_prestamos.FirstOrDefault( x=> x.id == 2)});
lista_prestamos_libros.Add(new Prestamos_Libros(){id=3, fecha_devolucion= new DateTime(2025,02,22), id_libros=3, id_prestamos=3, _id_libros=lista_libros.FirstOrDefault( x=> x.id == 3), _id_prestamos=lista_prestamos.FirstOrDefault( x=> x.id == 3)});
lista_prestamos_libros.Add(new Prestamos_Libros(){id=4, fecha_devolucion= new DateTime(2025,03,03), id_libros=4, id_prestamos=4, _id_libros=lista_libros.FirstOrDefault( x=> x.id == 4), _id_prestamos=lista_prestamos.FirstOrDefault( x=> x.id == 4)});

var lista_libros_autores = new List<Libros_Autores>();
lista_libros_autores.Add(new Libros_Autores(){id = 1, id_libros = 1, id_autores = 1, _id_libros = lista_libros.FirstOrDefault(x => x.id == 1)});
lista_libros_autores.Add(new Libros_Autores(){id = 2, id_libros = 2, id_autores = 2, _id_libros = lista_libros.FirstOrDefault(x => x.id == 2)});
lista_libros_autores.Add(new Libros_Autores(){id = 3, id_libros = 3, id_autores = 3, _id_libros = lista_libros.FirstOrDefault(x => x.id == 3)});
lista_libros_autores.Add(new Libros_Autores(){id = 4, id_libros = 3, id_autores = 4, _id_libros = lista_libros.FirstOrDefault(x => x.id == 4)});
lista_libros_autores.Add(new Libros_Autores(){id = 5, id_libros = 4, id_autores = 5, _id_libros = lista_libros.FirstOrDefault(x => x.id == 5)});

var lista_libros_generos = new List<Libros_Generos>();
lista_libros_generos.Add(new Libros_Generos(){id = 1, id_libros = 1, id_generos = 1, _id_libros = lista_libros.FirstOrDefault(x => x.id == 1), _id_generos = lista_generos.FirstOrDefault(x => x.id == 1)});
lista_libros_generos.Add(new Libros_Generos(){id = 2, id_libros = 1, id_generos = 2, _id_libros = lista_libros.FirstOrDefault(x => x.id == 1), _id_generos = lista_generos.FirstOrDefault(x => x.id == 2)});
lista_libros_generos.Add(new Libros_Generos(){id = 3, id_libros = 1, id_generos = 3, _id_libros = lista_libros.FirstOrDefault(x => x.id == 1), _id_generos = lista_generos.FirstOrDefault(x => x.id == 3)});
lista_libros_generos.Add(new Libros_Generos(){id = 4, id_libros = 2, id_generos = 4, _id_libros = lista_libros.FirstOrDefault(x => x.id == 2), _id_generos = lista_generos.FirstOrDefault(x => x.id == 4)});
lista_libros_generos.Add(new Libros_Generos(){id = 5, id_libros = 2, id_generos = 5, _id_libros = lista_libros.FirstOrDefault(x => x.id == 2), _id_generos = lista_generos.FirstOrDefault(x => x.id == 5)});
lista_libros_generos.Add(new Libros_Generos(){id = 6, id_libros = 2, id_generos = 6, _id_libros = lista_libros.FirstOrDefault(x => x.id == 2), _id_generos = lista_generos.FirstOrDefault(x => x.id == 6)});
lista_libros_generos.Add(new Libros_Generos(){id = 7, id_libros = 3, id_generos = 7, _id_libros = lista_libros.FirstOrDefault(x => x.id == 3), _id_generos = lista_generos.FirstOrDefault(x => x.id == 7)});
lista_libros_generos.Add(new Libros_Generos(){id = 8, id_libros = 4, id_generos = 7, _id_libros = lista_libros.FirstOrDefault(x => x.id == 4), _id_generos = lista_generos.FirstOrDefault(x => x.id == 7)});

Console.WriteLine(lista_editoriales.Count);
Console.WriteLine(lista_generos.Count);
Console.WriteLine(lista_libros.Count);
Console.WriteLine(lista_autores.Count);
Console.WriteLine(lista_roles.Count);
Console.WriteLine(lista_usuarios.Count);
Console.WriteLine(lista_prestamos.Count);
Console.WriteLine(lista_prestamos_libros.Count);
Console.WriteLine(lista_libros_autores.Count);
Console.WriteLine(lista_libros_generos.Count);



public class Editoriales 
{

    public int id {get; set;} // identificador de la editorial 
    public string? nombre {get; set;} // información de la editorial 
    public string? correo {get; set;} // información de la editorial, este atriburo se agrego para la entrega dos 
    public List<Libros>? Libros {get; set;}
}

public class Generos  
{

    public int id {get; set;}
    public string? nombre {get; set;} 
    public string? descripción {get; set;} 
    public List<Libros_Generos>? Libros_Generos {get; set;}
}

public class Autores  
{

    public int id {get; set;}
    public string? nombre {get; set;}    
    public string? apellido {get; set;} 
    public List<Libros_Autores>? Libros_Autores {get; set;}
    
}

public class Roles  
{

    public int id {get; set;} 
    public string? nombre {get; set;} 
    public string? descripcion {get; set;}  
    public List<Usuarios>? Usuarios {get; set;}
}

public class Prestamos  
{

    public int id {get; set;} 
    public string? codigo {get; set;} 
    public DateTime fecha_prestamo {get; set;} 
    public DateTime fecha_devolucion {get; set;} 
    public int id_usuarios {get; set;} 
    public Usuarios? _id_usuarios {get; set;} 
    public List<Usuarios>? Usuarios {get; set;}
    public List<Prestamos_Libros>? Prestamos_Libros {get; set;}

}

public class Libros 

{

    public int id {get; set;} 
    public string? titulo {get; set;} 
    public int cantidad {get; set;} 
    public string? estado {get; set;} 
    public string? año_publicacion {get; set;} 
    public int id_editoriales {get; set;} 
    public Editoriales? _id_editoriales {get; set;}   
    public List<Libros_Generos>? Libros_Generos {get; set;}
    public List<Libros_Autores>? Libros_Autores {get; set;}
    public List<Prestamos_Libros>? Prestamos_Libros {get; set;}

}

public class Prestamos_Libros  
{

    public int id {get; set;} 
    public DateTime fecha_devolucion {get; set;} 
    public int id_libros {get; set;} 
    public int id_prestamos {get; set;} 
    public Libros? _id_libros {get; set;}  
    public Prestamos? _id_prestamos {get; set;}  
    
}

public class Libros_Autores  
{

    public int id {get; set;} 
    public int id_libros {get; set;} 
    public int id_autores {get; set;} 
    public Libros? _id_libros {get; set;}  
    public Autores? _id_autores {get; set;}   
    
}

public class Libros_Generos  
{

    public int id {get; set;}  
    public int id_libros {get; set;}
    public int id_generos {get; set;}
    public Libros? _id_libros {get; set;}  
    public Generos? _id_generos {get; set;}   
    
}

public class Usuarios    

{

    public int id {get; set;} 
    public string? nombre {get; set;} 
    public string? apellido {get; set;} 
    public string? correo {get; set;}  
    public string? telefono {get; set;}  
    public int id_roles {get; set;} 
    public Roles? _id_roles {get; set;} 
    
}









