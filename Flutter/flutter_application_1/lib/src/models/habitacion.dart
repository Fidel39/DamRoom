class Habitaciones{
  List<Habitacion> items = [];
  Habitaciones();
  Habitaciones.fromJsonList(List<dynamic> jsonList){
    if (jsonList == null) return;
    for (var item in jsonList) {
      final habitacion = new Habitacion.fromJsonMap(item);
      items.add(habitacion);
    }
  }
}

class Habitacion{
  int? id;
  String? caracteristicas;
  double? importe;
  String? tipo;

  Habitacion({
    required this.id,
    required this.caracteristicas,
    required this.importe,
    required this.tipo,

  });

  Habitacion.fromJsonMap(Map<String, dynamic> json){
    id = json['id'];
    caracteristicas = json['caracteristicas'];
    importe = json['importe'];
    tipo = json['tipo'];
  }
}