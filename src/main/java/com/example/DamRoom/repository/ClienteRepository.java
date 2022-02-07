package com.example.DamRoom.repository;

import com.example.DamRoom.domain.Cliente;
import org.springframework.data.repository.CrudRepository;

import java.util.Optional;
import java.util.Set;

public interface ClienteRepository extends CrudRepository<Cliente, String> {
    Optional<Cliente> findByDni(String DNI);
    Set<Cliente> findAll();
}
