class Clientes{
  List<Cliente> items = [];
  Clientes();
  Clientes.fromJsonList(List<dynamic> jsonList){
    if(jsonList == null) return;
    for(var item in jsonList){
      final clente = new Cliente.fromJsonMap(item);
      items.add(clente);
      }
  }
}

class Cliente{
  String? dni;
  String? nombre;
  String? apellido;
  String? direccion;
  int? telefono;

  Cliente({
    required this.dni, 
    required this.nombre, 
    required this.apellido, 
    required this.direccion, 
    required this.telefono
  });

  Cliente.fromJsonMap(Map<String, dynamic> json){
    dni = json['din'];
    nombre = json['nombre'];
    apellido = json['apellido'];
    direccion = json['direccion'];
    telefono = json['telefono'];
  }
    
}
