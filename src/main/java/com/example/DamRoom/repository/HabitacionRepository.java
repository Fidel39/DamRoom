package com.example.DamRoom.repository;

import com.example.DamRoom.domain.Cliente;
import org.springframework.data.repository.CrudRepository;
import com.example.demo.domain.Habitacion;

public interface HabitacionRepository extends CrudRepository<Cliente, Long> {

    Optional<Habitacion>


}
