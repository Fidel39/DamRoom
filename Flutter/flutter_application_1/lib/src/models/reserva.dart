
import 'dart:ffi';

class Reservas{
  List<Reserva> items = [];
  Reservas();
  Reservas.fromJsonList(List<dynamic> jsonList) {
    if (jsonList == null) return;
    for (var item in jsonList) {
      final reserva = new Reserva.fromJsonMap(item);
      items.add(reserva);
    }
  }
}

class Reserva{
  DateTime? fechaIni;
  DateTime? fechaFin;
  Float? importe;

  Reserva({
    required this.fechaIni,
    required this.fechaFin,
    required this.importe,
  });

  Reserva.fromJsonMap(Map<String, dynamic> json){
    fechaIni = json['fechaIni'];
    fechaFin = json['fechaFin'];
    importe = json['importe'];
  }
}