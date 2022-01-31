package com.example.DamRoom.service;

import com.example.DamRoom.domain.Reservas;

import java.util.Date;
import java.util.Set;

public interface ReservaService {

    Set<Reservas> findAll();
    Set<Reservas> findById(int id);
    Set<Reservas> findByFechaIn(Date fechaIn);
    Set<Reservas> findByFechaFin(Date fechaFin);
    Set<Reservas> findByImporte(float importe);
    Set<Reservas> findByChekin (boolean chekin);
    Set<Reservas> findByChekout (boolean chekout);
    Reservas addReserva(Reservas reservas);
    Reservas modifyReserva(int id, Reservas newReserva);
    void deleteReserva(int id);
}
