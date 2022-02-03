package com.example.DamRoom.service;

import com.example.DamRoom.domain.Cliente;
import com.example.DamRoom.exception.ClienteNotFoundException;
import com.example.DamRoom.repository.ClienteRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.util.Optional;
import java.util.Set;

@Service
@Transactional
public class ClienteServiceImpl implements ClienteService {

    @Autowired
    private ClienteRepository clienteRepository;


    @Override
    public Optional<Cliente> findByDni(String DNI){
        return clienteRepository.findByDni(DNI);
    }

    @Override
    public Set<Cliente> findAll(){
        return clienteRepository.findAll();
    }

    @Override
    public Cliente addCliente(Cliente cliente){
        return clienteRepository.save(cliente);
    }

    @Override
    public Cliente modificarCliente(String DNI, Cliente cliente){
        Cliente cliente1 = clienteRepository.findByDni(DNI)
                .orElseThrow(() -> new ClienteNotFoundException(DNI));
        cliente.setDni(cliente1.getDni());
        return clienteRepository.save(cliente);

    }

    @Override
    public void deleteCliente(String Dni){
        clienteRepository.findByDni(Dni)
                .orElseThrow(() -> new ClienteNotFoundException(Dni));
        clienteRepository.deleteById(Dni);
    }




}
