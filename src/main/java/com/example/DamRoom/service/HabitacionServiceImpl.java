package com.example.DamRoom.service;

import com.example.DamRoom.repository.HabitacionRepository;
import com.example.demo.domain.Habitacion;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.util.Optional;
import java.util.Set;

@Service
@Transactional
public class HabitacionServiceImpl implements HabitacionService{

    @Autowired
    private HabitacionRepository habitacionRepository;

    @Override
    public Optional<Habitacion> findBynumeroHabitacion(Long numeroHabitacion) {
        return Optional.empty();
    }

    @Override
    public Set<Habitacion> findAllRooms() {
        return null;
    }

    @Override
    public Habitacion addHabitacion(Habitacion habitacion) {
        return null;
    }

    @Override
    public Habitacion modificarHabitacion(Long numeroHabitacion, Habitacion habitacion) {
        return null;
    }

    @Override
    public void deleteHabitacion(Long numeroHabitacion) {

    }
}
