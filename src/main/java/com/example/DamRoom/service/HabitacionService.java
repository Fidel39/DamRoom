package com.example.DamRoom.service;

import java.util.Optional;
import java.util.Set;

import com.example.DamRoom.domain.Habitacion;

public interface HabitacionService {

    Optional<Habitacion> findByIdRoom(Long idRoom);
    Set<Habitacion> findAllRooms();
    Habitacion addHabitacion(Habitacion habitacion);
    Habitacion modificarHabitacion(Long idRoom,Habitacion habitacion);
    void deleteHabitacion(Long idRoom);

}
