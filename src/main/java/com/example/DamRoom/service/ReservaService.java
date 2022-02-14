package com.example.DamRoom.service;

import com.example.DamRoom.domain.Reservas;

import java.util.Date;
import java.util.Optional;
import java.util.Set;

public interface ReservaService {

    Set<Reservas> findAll();
    Optional<Reservas> findReservaByidReserva(long idReserva);
    Set<Reservas> findReservaBydniCliente(String dniCliente);
    Set<Reservas> findReservaByfechaIni(Date fechaIni);
    Set<Reservas> findReservaByfechaFin(Date fechaFin);
    Set<Reservas> findReservaByimporte(float importe);
    Set<Reservas> findReservasByestado(String estado);
    Set<Reservas> estadisticaReservasAnuales(String anyo);
    Reservas addReserva(Reservas reservas);
    Reservas modifyReserva(long idReserva, Reservas newReserva);
    Reservas checkReserva(String check,Reservas newReserva);
    void deleteReserva(long id);
}
