package com.example.DamRoom.service;

import com.example.DamRoom.domain.Reservas;
import com.example.DamRoom.domain.ReservasId;

import java.util.Date;
import java.util.Optional;
import java.util.Set;

public interface ReservaService {

    Set<Reservas> findAll();
    Optional<Reservas> findReservaById(ReservasId id);
    Set<Reservas> findReservaByfechaIni(Date fechaIni);
    Set<Reservas> findReservaByfechaFin(Date fechaFin);
    Set<Reservas> findReservaByimporte(float importe);
    //Set<Reservas> findReservaBycheckIn (Byte checkIn);
    Set<Reservas> findReservaBycheckOut (Byte checkOut);
    Reservas addReserva(Reservas reservas);
    Reservas modifyReserva(ReservasId id, Reservas newReserva);
    //void deleteReserva(ReservasId id);
}
