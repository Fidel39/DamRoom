package com.example.DamRoom.service;

import java.util.Optional;
import java.util.Set;

import com.example.DamRoom.domain.Habitacion;

public interface HabitacionService {

    Optional<Habitacion> findBynumeroHabitacion(Long numeroHabitacion);
    Set<Habitacion> findAllRooms();
    Habitacion addHabitacion(Habitacion habitacion);
    Habitacion modificarHabitacion(Long numeroHabitacion,Habitacion habitacion);
    void deleteHabitacion(Long numeroHabitacion);

}
