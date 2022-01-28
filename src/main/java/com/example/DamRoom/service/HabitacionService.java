package com.example.DamRoom.service;

import java.util.Optional;
import java.util.Set;

import com.example.demo.domain.Habitacion;

public interface HabitacionService {

    Optional<Habitacion> findBynumeroHabitacion(Long numeroHabitacion);
    Set<Habitacion> findAll();
    Habitacion addHabitacion(Habitacion habitacion);
    Habitacion modificarHabitacion(Long numeroHabitacion,Habitacion habitacion);
    void deleteHabitacion(Long numeroHabitacion);

}
