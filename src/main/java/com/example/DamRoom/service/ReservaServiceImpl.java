package com.example.DamRoom.service;

import com.example.DamRoom.domain.Reservas;
import com.example.DamRoom.exception.ReservaNotFoundException;
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

    @Override
    public Set<Reservas> findAll() {
        return reservaRepository.findAll();
    }

    @Override
    public Set<Reservas> findById(int id){
        return reservaRepository.findById(id);
    }

    @Override
    public Set<Reservas> findByFechaIn(Date fechaIn){
        return reservaRepository.findByFechaIn(fechaIn);
    }

    @Override
    public Set<Reservas> findByFechaFin(Date fechaFin){
        return reservaRepository.findByFechaFin(fechaFin);
    }

    @Override
    public Set<Reservas> findByImporte(float importe){
        return reservaRepository.findByImporte(importe);
    }

    @Override
    public Set<Reservas> findByChekin(boolean chekin){
        return reservaRepository.findByChekin(chekin);
    }

    @Override
    public Set<Reservas> findByChekout(boolean chekout){
        return reservaRepository.findByChekout(chekout);
    }

    @Override
    public Optional<Reservas> findAllReservas(int id){
        return reservaRepository.findAllReservas(id);
    }

    @Override
    public Reservas addReserva(Reservas reservas){
        return reservaRepository.save(reservas);
    }

    @Override
    public Reservas modifyReserva(int id, Reservas newReserva){
        Reservas reservas = reservaRepository.findAllReservas(id)
                .orElseThrow(() -> new ReservaNotFoundException(id));
        newReserva.setCodReserva(reservas.getCodReserva());
        return reservaRepository.save(newReserva);
    }


    @Override
    public void deleteReserva(int id){
        reservaRepository.findAllReservas(id)
                .orElseThrow(() -> new ReservaNotFoundException(id));
        reservaRepository.deleteById(id);
    }


}
