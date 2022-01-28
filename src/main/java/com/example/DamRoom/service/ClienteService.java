package com.example.DamRoom.service;

import com.example.DamRoom.domain.Cliente;

import java.util.Optional;
import java.util.Set;

public interface ClienteService {

    Optional<Cliente> findByDni(String DNI);
    Set<Cliente> findAll();
    Cliente addCliente(Cliente cliente);
    Cliente modificarCliente(String DNI, Cliente cliente);
    void deleteCliente(String DNI);

}
