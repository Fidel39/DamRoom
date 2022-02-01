package com.example.DamRoom.repository;

import com.example.DamRoom.domain.Cliente;
import com.example.DamRoom.domain.Habitacion;
import org.springframework.data.repository.CrudRepository;


import java.util.Optional;
import java.util.Set;

public interface HabitacionRepository extends CrudRepository<Habitacion, Long> {

    Optional<Habitacion> findBynumeroHabitacion(Long numeroHabitacion);
    Set<Habitacion> findAllRooms();

}
