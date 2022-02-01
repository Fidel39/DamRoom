package com.example.DamRoom.service;


import com.example.DamRoom.exception.HabitacionNotFoundException;
import com.example.DamRoom.repository.HabitacionRepository;
import com.example.DamRoom.domain.Habitacion;
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
        return habitacionRepository.findBynumeroHabitacion(numeroHabitacion);
    }

    @Override
    public Set<Habitacion> findAllRooms() {
        return habitacionRepository.findAllRooms();
    }

    @Override
    public Habitacion addHabitacion(Habitacion habitacion) {
        return habitacionRepository.save(habitacion);
    }


    @Override
    public Habitacion modificarHabitacion(Long numeroHabitacion, Habitacion habitacion) {
        Habitacion habitacion1 = habitacionRepository.findBynumeroHabitacion(numeroHabitacion)
                .orElseThrow(() -> new HabitacionNotFoundException(numeroHabitacion));
        habitacion.setNumeroHabitacion(habitacion1.getNumeroHabitacion());
        return habitacionRepository.save(habitacion);
    }

    @Override
    public void deleteHabitacion(Long numeroHabitacion) {
        habitacionRepository.findBynumeroHabitacion(numeroHabitacion)
                .orElseThrow(() -> new HabitacionNotFoundException(numeroHabitacion));
        habitacionRepository.deleteById(numeroHabitacion);
    }
}
