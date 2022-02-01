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
    public Optional<Habitacion> findByIdRoom(Long idRoom) {
        return habitacionRepository.findByIdRoom(idRoom);
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
    public Habitacion modificarHabitacion(Long idRoom, Habitacion habitacion) {
        Habitacion habitacion1 = habitacionRepository.findByIdRoom(idRoom)
                .orElseThrow(() -> new HabitacionNotFoundException(idRoom));
        habitacion.setIdRoom(habitacion1.getIdRoom());
        return habitacionRepository.save(habitacion);
    }

    @Override
    public void deleteHabitacion(Long idRoom) {
        habitacionRepository.findByIdRoom(idRoom)
                .orElseThrow(() -> new HabitacionNotFoundException(idRoom));
        habitacionRepository.deleteById(idRoom);
    }
}
