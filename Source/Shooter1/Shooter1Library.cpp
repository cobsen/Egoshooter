// Fill out your copyright notice in the Description page of Project Settings.


#include "Shooter1Library.h"
#include "SampleHTML5.h"

void UShooter1Library::SampleInit()
{
#ifdef __EMSCRIPTEN__
	/* register the listener */
	SampleHTML5_RegisterStringFunction(&Callback_RegisterStringFunction);
#endif

#if PLATFORM_HTML5
	UE_InitSampleHTML5();
#endif
}

void UShooter1Library::Callback_RegisterStringFunction(const char* str)
{

	UE_LOG(LogTemp, Log, TEXT("UShooter1Library::Callback_RegisterStringFunction invoked\r\n"));
	UE_LOG(LogTemp, Log, TEXT("%str"), *str);
}
