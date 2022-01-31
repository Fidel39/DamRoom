package com.example.DamRoom.repository;

import com.example.DamRoom.domain.Cliente;
import org.springframework.data.repository.CrudRepository;
import com.example.demo.domain.Habitacion;

import java.util.Optional;
import java.util.Set;

public interface HabitacionRepository extends CrudRepository<Cliente, Long> {

    Optional<Habitacion> findBynumeroHabitacion(Long numeroHabitacion);
    Set<Habitacion> findAllRooms();

}
