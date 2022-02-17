
import 'dart:ffi';

import 'package:flutter_application_1/src/models/cliente.dart';
import 'package:flutter_application_1/src/models/habitacion.dart';

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
  int? idReserva;
  String? fechaIni;
  String? fechaFin;
  double? importe;
  String? estado;
  String? dniCliente;
  String? caracteristicas;
  Cliente? cliente;
  Habitacion? habitacion;

  Reserva({
    required this.idReserva,
    required this.fechaIni,
    required this.fechaFin,
    required this.importe,
    required this.estado,
    required this.dniCliente,
    required this.caracteristicas            
  });

  Reserva.fromJsonMap(Map<String, dynamic> json){
    idReserva = json['idReserva'];
    fechaIni = json['fechaIni'] ;
    fechaFin = json['fechaFin'] ;
    importe = json['importe'];
    estado = json['estado'];
    dniCliente = json['dniCliente'];
    caracteristicas = json['caracteristicas'];

    if(json['cliente'] != null){
      cliente = Cliente.fromJsonMap(json['cliente']);
    }

    if(json['habitacion'] != null){
        habitacion = Habitacion.fromJsonMap(json['habitacion']);
    }
  }
}