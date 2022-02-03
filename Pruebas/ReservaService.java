package com.example.DamRoom.service;

import com.example.DamRoom.domain.Reservas;

import java.util.Date;
import java.util.Optional;
import java.util.Set;

public interface ReservaService {

    Set<Reservas> findAll();
    Optional<Reservas> findBycodReserva(int codReserva);
    Set<Reservas> findByFechaIni(Date fechaIni);
    Set<Reservas> findByFechaFin(Date fechaFin);
    Set<Reservas> findByImporte(float importe);
    Set<Reservas> findByCheckIn (boolean checkIn);
    Set<Reservas> findByCheckOut (boolean checkOut);
    Reservas addReserva(Reservas reservas);
    Reservas modifyReserva(int codReserva, Reservas newReserva);
    void deleteReserva(int codReserva);
}
