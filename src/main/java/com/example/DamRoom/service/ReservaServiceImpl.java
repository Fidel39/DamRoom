package com.example.DamRoom.service;

import com.example.DamRoom.domain.Cliente;
import com.example.DamRoom.domain.Habitacion;
import com.example.DamRoom.domain.Reservas;
import com.example.DamRoom.domain.ReservasId;
import com.example.DamRoom.exception.ReservaNotFoundException;
import com.example.DamRoom.repository.ClienteRepository;
import com.example.DamRoom.repository.HabitacionRepository;
import com.example.DamRoom.repository.ReservaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.Date;
import java.util.Set;
import java.util.Optional;

@Service
@Transactional
public class ReservaServiceImpl implements ReservaService{

    @Autowired
    private ReservaRepository reservaRepository;
    private ClienteRepository clienteRepository;
    private HabitacionRepository habitacionRepository;

    @Override
    public Set<Reservas> findAll() {
        return reservaRepository.findAll();
    }


    @Override
    public Set<Reservas> findReservaByfechaIni(Date fechaIni){
        return reservaRepository.findReservaByfechaIni(fechaIni);
    }

    @Override
    public Set<Reservas> findReservaByfechaFin(Date fechaFin){
        return reservaRepository.findReservaByfechaFin(fechaFin);
    }

    @Override
    public Set<Reservas> findReservaByimporte(float importe){
        return reservaRepository.findReservaByimporte(importe);
    }

   /*@Override
    public Set<Reservas> findReservaBycheckIn(Byte checkIn){
        return reservaRepository.findReservaBycheckIn(checkIn);
    }*/

    @Override
    public Set<Reservas> findReservaBycheckOut(Byte checkOut){
        return reservaRepository.findReservaBycheckOut(checkOut);
    }

    @Override
    public Optional<Reservas> findReservaById(ReservasId id){
        return reservaRepository.findReservaById(id);
    }

    @Override
    public Reservas addReserva(Reservas reservas){

        return reservaRepository.save(reservas);
    }

    @Override
    public Reservas modifyReserva(ReservasId id, Reservas newReserva){
        Reservas reservas = reservaRepository.findReservaById(id)
                .orElseThrow(() -> new ReservaNotFoundException(id.getDNICliente()));
        newReserva.setId(reservas.getId());
        return reservaRepository.save(newReserva);
    }

/*    @Override
    public void deleteReserva(ReservasId id) {
        Reservas reservas = reservaRepository.findReservaById(id)
                .orElseThrow(() -> new ReservaNotFoundException(id.getDNICliente()));
        reservaRepository.delete(id);
    }*/


}
